using CV19_2.Infrastructure.Commands;
using CV19_2.Models.Decanat;
using CV19_2.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CV19_2.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        public ObservableCollection<Group> Groups { get; }
        #region Selected Group : Group - Выбранная группа

        /// <summary> Выбранная группа </summary>
        private Group _selectedGroup;

        /// <summary> Выбранная группа </summary>
        public Group SelectedGroup 
        {
            get => _selectedGroup; 
            set => Set(ref _selectedGroup, value); 
        }

        #endregion

        public MainWindowViewModel()
        {
            CloseApplicationCommand = new LambdaCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute);

            var student_index = 1;
            var students = Enumerable.Range(1, 10).Select(i => new Student 
            {
                Name= $"Name {student_index}",
                Surname = $"Surname {student_index}",
                Patronymic = $"Patronymic {student_index++}",
                Birthday = DateTime.Now,
                Rating = 0
            });

            var groups = Enumerable.Range(1, 20).Select(i => new Group
            {
                Name=$"Группа {i}",
                Students = new ObservableCollection<Student>(students)
            });

            Groups = new ObservableCollection<Group>(groups);
        }
        #region - Заголовок Окна
        private string _title="Анализ статистики CV19";
        /// <summary>
        /// Заголовок окна
        /// </summary>
        /// 
        public string Title
        {
            get => _title;
            //set
            //{
            //    if (Equals(value, _title)) return;
            //    _title = value;
            //    OnPropertyChanged();
            //}
            set
            {
                Set(ref _title, value); 
            }
        }
        #endregion

        #region Status : string- Статус программы
        // <summary>Статус программы</summary>
        private string _status = "Готов!";
        // <summary> Статус программы</summary>
        public string Status
        {
            get => _status;
            set => Set(ref _status, value); 
        }
        // <summary> Статус программы</summary>
        #endregion

        #region Комманда OnCloseApplication
        public ICommand CloseApplicationCommand{ get;}
        private bool CanCloseApplicationCommandExecute(object p)
        {
            return true;
        }
        private void OnCloseApplicationCommandExecuted(object p)
        {
            Application.Current.Shutdown(); 
        }
        #endregion




    }
}
