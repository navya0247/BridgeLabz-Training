using Microsoft.EntityFrameworkCore;
using FundooNotesApp.BusinessLayer.Service;
using FundooNotesApp.ModelLayer.Dtos.Request;
using FundooNotesApp.ModelLayer.Exceptions;
using FundooNotesApp.RepositoryLayer.Context;
using FundooNotesApp.RepositoryLayer.Service;

namespace FundooNotesApp.Tests
{
    [TestClass]
    public class LabelTests
    {
      
        private AppDbContext GetInMemoryContext()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;
            return new AppDbContext(options);
        }

        [TestMethod]
        public void CreateLabel_ShouldSucceed_AndLinkToCorrectNote()
        {
            var context = GetInMemoryContext();
            var notesService = new NotesService(new NotesRepository(context));
            var labelService = new LabelService(new LabelRepository(context));

            var note = notesService.CreateNote(new NotesRequestDto { Title = "Note for Label" }, userId: 1);
            var label = labelService.CreateLabel(new LabelRequestDto { LabelName = "Work", NoteId = (int)note.NoteId }, userId: 1);

            Assert.AreEqual("Work", label.LabelName);
            Assert.AreEqual(note.NoteId, label.NoteId);
        }

        [TestMethod]
        public void GetAllLabels_ShouldReturnOnlyThatUsersLabels()
        {
            var context = GetInMemoryContext();
            var notesService = new NotesService(new NotesRepository(context));
            var labelService = new LabelService(new LabelRepository(context));

            var note1 = notesService.CreateNote(new NotesRequestDto { Title = "Note A" }, userId: 1);
            var note2 = notesService.CreateNote(new NotesRequestDto { Title = "Note B" }, userId: 2);
            labelService.CreateLabel(new LabelRequestDto { LabelName = "User1 Label", NoteId = (int)note1.NoteId }, userId: 1);
            labelService.CreateLabel(new LabelRequestDto { LabelName = "User2 Label", NoteId = (int)note2.NoteId }, userId: 2);

            var user1Labels = labelService.GetAllLabels(userId: 1);

            Assert.AreEqual(1, user1Labels.Count);
            Assert.AreEqual("User1 Label", user1Labels[0].LabelName);
        }

        [TestMethod]
        public void EditLabel_ShouldUpdateLabelName()
        {
            var context = GetInMemoryContext();
            var notesService = new NotesService(new NotesRepository(context));
            var labelService = new LabelService(new LabelRepository(context));

            var note = notesService.CreateNote(new NotesRequestDto { Title = "Note" }, userId: 1);
            var label = labelService.CreateLabel(new LabelRequestDto { LabelName = "Old Name", NoteId = (int)note.NoteId }, userId: 1);

            var updated = labelService.EditLabel(label.LabelId, new LabelRequestDto { LabelName = "New Name", NoteId = (int)note.NoteId }, userId: 1);

            Assert.AreEqual("New Name", updated.LabelName);
        }

        [TestMethod]
        public void DeleteLabel_ShouldSucceed_WhenLabelBelongsToUser()
        {
            var context = GetInMemoryContext();
            var notesService = new NotesService(new NotesRepository(context));
            var labelService = new LabelService(new LabelRepository(context));

            var note = notesService.CreateNote(new NotesRequestDto { Title = "Note" }, userId: 1);
            var label = labelService.CreateLabel(new LabelRequestDto { LabelName = "ToDelete", NoteId = (int)note.NoteId }, userId: 1);

            labelService.DeleteLabel(label.LabelId, userId: 1);

            // getting all labels again should not include the deleted one
            var labels = labelService.GetAllLabels(userId: 1);
            Assert.AreEqual(0, labels.Count);
        }

        [TestMethod]
        public void DeleteLabel_ShouldThrowException_WhenLabelDoesNotBelongToUser()
        {
            var context = GetInMemoryContext();
            var notesService = new NotesService(new NotesRepository(context));
            var labelService = new LabelService(new LabelRepository(context));

            var note = notesService.CreateNote(new NotesRequestDto { Title = "Note" }, userId: 1);
            var label = labelService.CreateLabel(new LabelRequestDto { LabelName = "Personal", NoteId = (int)note.NoteId }, userId: 1);

            try
            {
                labelService.DeleteLabel(label.LabelId, userId: 2);
                Assert.Fail("Expected LabelNotFoundException was not thrown");
            }
            catch (LabelNotFoundException) { }
        }
    }
}