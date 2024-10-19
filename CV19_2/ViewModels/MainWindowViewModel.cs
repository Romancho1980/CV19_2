using CV19_2.Infrastructure.Commands;
using CV19_2.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CV19_2.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        public MainWindowViewModel()
        {
            CloseApplicationCommand = new LambdaCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute);
        }

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
