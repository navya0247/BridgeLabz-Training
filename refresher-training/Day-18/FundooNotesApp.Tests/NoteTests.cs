using Microsoft.EntityFrameworkCore;
using FundooNotesApp.BusinessLayer.Service;
using FundooNotesApp.ModelLayer.Dtos.Request;
using FundooNotesApp.ModelLayer.Exceptions;
using FundooNotesApp.RepositoryLayer.Context;
using FundooNotesApp.RepositoryLayer.Service;

namespace FundooNotesApp.Tests
{
    [TestClass]
    public class NoteTests
    {
        
        private AppDbContext GetInMemoryContext()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;
            return new AppDbContext(options);
        }

        // builds NotesService 
        private NotesService GetNotesService(AppDbContext context)
        {
            var notesRepository = new NotesRepository(context);
            return new NotesService(notesRepository);
        }

        [TestMethod]
        public void CreateNote_ShouldSucceed_AndSaveCorrectly()
        {
            var notesService = GetNotesService(GetInMemoryContext());

            var result = notesService.CreateNote(new NotesRequestDto { Title = "Test Note", Description = "Test Desc" }, userId: 1);

            Assert.AreEqual("Test Note", result.Title);
            Assert.IsTrue(result.NoteId > 0);
        }

        [TestMethod]
        public void GetAllNotes_ShouldReturnOnlyThatUsersNotes()
        {
            var notesService = GetNotesService(GetInMemoryContext());

            notesService.CreateNote(new NotesRequestDto { Title = "User1 Note" }, userId: 1);
            notesService.CreateNote(new NotesRequestDto { Title = "User2 Note" }, userId: 2);

            var user1Notes = notesService.GetAllNotes(userId: 1);

            // only user 1's note should come back, not user 2's
            Assert.AreEqual(1, user1Notes.Count);
            Assert.AreEqual("User1 Note", user1Notes[0].Title);
        }

        [TestMethod]
        public void GetNoteById_ShouldThrowException_WhenNoteBelongsToDifferentUser()
        {
            var notesService = GetNotesService(GetInMemoryContext());
            var created = notesService.CreateNote(new NotesRequestDto { Title = "Private Note" }, userId: 1);

            try
            {
                notesService.GetNoteById(created.NoteId, userId: 2);
                Assert.Fail("Expected NoteNotFoundException was not thrown");
            }
            catch (NoteNotFoundException) { }
        }

        [TestMethod]
        public void DeleteNote_ShouldSucceed_AndRemoveNote()
        {
            var notesService = GetNotesService(GetInMemoryContext());
            var created = notesService.CreateNote(new NotesRequestDto { Title = "To Delete" }, userId: 1);

            notesService.DeleteNote(created.NoteId, userId: 1);

            try
            {
                notesService.GetNoteById(created.NoteId, userId: 1);
                Assert.Fail("Note should no longer exist after delete");
            }
            catch (NoteNotFoundException) { }
        }

        [TestMethod]
        public void TogglePin_ShouldFlipPinStatus()
        {
            var notesService = GetNotesService(GetInMemoryContext());
            var created = notesService.CreateNote(new NotesRequestDto { Title = "Pin Test" }, userId: 1);

            var pinned = notesService.TogglePin(created.NoteId, userId: 1);
            Assert.IsTrue(pinned.Pin);

            
            var unpinned = notesService.TogglePin(created.NoteId, userId: 1);
            Assert.IsFalse(unpinned.Pin);
        }

        [TestMethod]
        public void ToggleArchive_ShouldFlipArchiveStatus()
        {
            var notesService = GetNotesService(GetInMemoryContext());
            var created = notesService.CreateNote(new NotesRequestDto { Title = "Archive Test" }, userId: 1);

            var archived = notesService.ToggleArchive(created.NoteId, userId: 1);

            Assert.IsTrue(archived.Archive);
        }

        [TestMethod]
        public void ToggleTrash_ShouldFlipTrashStatus()
        {
            var notesService = GetNotesService(GetInMemoryContext());
            var created = notesService.CreateNote(new NotesRequestDto { Title = "Trash Test" }, userId: 1);

            var trashed = notesService.ToggleTrash(created.NoteId, userId: 1);

            Assert.IsTrue(trashed.Trash);
        }

        [TestMethod]
        public void SearchNotes_ShouldReturnOnlyMatchingTitles()
        {
            var notesService = GetNotesService(GetInMemoryContext());
            notesService.CreateNote(new NotesRequestDto { Title = "Grocery List" }, userId: 1);
            notesService.CreateNote(new NotesRequestDto { Title = "Work Notes" }, userId: 1);

            var results = notesService.SearchNotes(userId: 1, keyword: "Grocery");

            Assert.AreEqual(1, results.Count);
            Assert.AreEqual("Grocery List", results[0].Title);
        }

        [TestMethod]
        public void FilterNotes_ShouldReturnOnlyPinnedNotes()
        {
            var notesService = GetNotesService(GetInMemoryContext());
            var note1 = notesService.CreateNote(new NotesRequestDto { Title = "Pinned Note" }, userId: 1);
            notesService.CreateNote(new NotesRequestDto { Title = "Normal Note" }, userId: 1);
            notesService.TogglePin(note1.NoteId, userId: 1);

            var results = notesService.FilterNotes(userId: 1, pin: true, archive: null, trash: null);

            Assert.AreEqual(1, results.Count);
            Assert.AreEqual("Pinned Note", results[0].Title);
        }
    }
}