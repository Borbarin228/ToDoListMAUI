using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ToDoList
{
    public class TaskViewModel : INotifyPropertyChanged
    {

        private string task;
        private bool isdone;

        public string Task {
            get { return task; }

            set {
                task = value;
                onPropertyChanged("Task");
            } }   
        public bool IsDone {
            get { return isdone; }

            set {
                isdone = value;
                onPropertyChanged("Isdone");
            } }

        public event PropertyChangedEventHandler PropertyChanged;
        public void onPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}