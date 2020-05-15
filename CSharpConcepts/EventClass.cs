using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CSharpConcepts
{
    public class EventClass
    {
        public void start()
        {
            Photo photo = new Photo("Abc");
            PhotoEditor photoEditor = new PhotoEditor();

            photoEditor.PhotoEdited += mailservice;
            photoEditor.PhotoEdited += smsservice;

            photoEditor.Edit(photo);
        }

        private void mailservice(object source, EventArgs args)
        {
            Console.WriteLine("Sending Mail...");
        }

        private void smsservice(object source, EventArgs args)
        {
            Console.WriteLine("Sending sms...");
        }
    }

    public class PhotoEditor
    {
        public delegate void PhotoEditorEventHandler(object source, EventArgs args);

        public event PhotoEditorEventHandler PhotoEdited;

        public void Edit(Photo photo)
        {
            Console.WriteLine("Editing Photo...");
            Thread.Sleep(3000);

            OnPhotoEdited();
        }

        protected virtual void OnPhotoEdited()
        {
            if (PhotoEdited != null)
            {
                PhotoEdited(this, EventArgs.Empty);
            }
        }
    }

    public class Photo
    {
        public Photo(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
