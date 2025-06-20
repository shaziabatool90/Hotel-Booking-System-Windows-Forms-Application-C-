using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DP_Project
{
    // Subject class for managing observers
    public class BookingSubject
    {
        private List<BookingObserver> observers = new List<BookingObserver>();
        private string message = string.Empty;

        public string Message
        {
            get { return message; }
            set
            {
                message = value;
                NotifyAllObservers();
            }
        }

        public void Attach(BookingObserver observer)
        {
            observers.Add(observer);
        }

        private void NotifyAllObservers()
        {
            foreach (BookingObserver observer in observers)
            {
                observer.Update();
            }
        }
    }

    // Abstract Observer class
    public abstract class BookingObserver
    {
        protected BookingSubject? subject;
        public abstract void Update();
    }

    // Concrete Email Observer
    public class EmailNotification : BookingObserver
    {
        public EmailNotification(BookingSubject subject)
        {
            this.subject = subject;
            this.subject.Attach(this);
        }

        public override void Update()
        {
            // In a real application, this would send an actual email
            MessageBox.Show($"Email Notification: {subject?.Message}");
        }
    }

    // Concrete SMS Observer
    public class SMSNotification : BookingObserver
    {
        public SMSNotification(BookingSubject subject)
        {
            this.subject = subject;
            this.subject.Attach(this);
        }

        public override void Update()
        {
            // In a real application, this would send an actual SMS
            MessageBox.Show($"SMS Notification: {subject?.Message}");
        }
    }

}