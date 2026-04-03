using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Text;

namespace BridgeLabzTraining.collections.streams
{
    internal class ThreadCommunication
    {       
           public static void Main(string[] args)
            {
                try
                {
                    // Create a pipe server for writing
                    AnonymousPipeServerStream pipeServer =
                        new AnonymousPipeServerStream(PipeDirection.Out);

                    // Create a pipe client for reading
                    AnonymousPipeClientStream pipeClient =
                        new AnonymousPipeClientStream(PipeDirection.In,
                        pipeServer.ClientSafePipeHandle);

                    // Writer thread
                    Thread writerThread = new Thread(() =>
                    {
                        try
                        {
                            using (StreamWriter writer = new StreamWriter(pipeServer))
                            {
                                writer.AutoFlush = true; // ensures data is sent immediately

                                for (int i = 1; i <= 5; i++)
                                {
                                    string message = "Message " + i;
                                    Console.WriteLine("Writer wrote: " + message);
                                    writer.WriteLine(message);
                                    Thread.Sleep(500); // simulate delay
                                }
                            }
                        }
                        catch (IOException ex)
                        {
                            Console.WriteLine("Writer IOException: " + ex.Message);
                        }
                    });

                    // Reader thread
                    Thread readerThread = new Thread(() =>
                    {
                        try
                        {
                            using (StreamReader reader = new StreamReader(pipeClient))
                            {
                                string line;
                                while ((line = reader.ReadLine()) != null)
                                {
                                    Console.WriteLine("Reader read: " + line);
                                }
                            }
                        }
                        catch (IOException ex)
                        {
                            Console.WriteLine("Reader IOException: " + ex.Message);
                        }
                    });

                    // Start both threads
                    writerThread.Start();
                    readerThread.Start();

                    // Wait for both threads to finish
                    writerThread.Join();
                    readerThread.Join();
                }
                catch (IOException ex)
                {
                    Console.WriteLine("Pipe creation error: " + ex.Message);
                }
            }
        }
    }

