using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace Audio_Player
{

    public partial class MainWindow : Window
    {

        private void RenamePL_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //делаем текстбокс с названием плейлиста редактируемым
            PlayListName_TB.IsReadOnly = false;
            PlayListName_TB.IsHitTestVisible = true;
            PlayListName_TB.BorderThickness = new Thickness(1);
            PlayListName_TB.CaretBrush = Brushes.White;
            PlayListName_TB.CaretIndex = PlayListName_TB.Text.Length;
            PlayListName_TB.Focus();
        }

        private void PlayListName_TB_KeyDown(object sender, KeyEventArgs e)
        {
            //убераем возможность редактирования текстбокса с названием (данные названия обновляются)
            if (e.Key == Key.Enter && PlayListName_TB.IsHitTestVisible)
            {
                PlayListName_TB.IsHitTestVisible = false;
                PlayListName_TB.IsReadOnly = true;
                PlayListName_TB.BorderThickness = new Thickness(0);
                PlayListName_TB.IsReadOnlyCaretVisible = false;
            }
        }

        private void PlayPlayList_Click(object sender, MouseButtonEventArgs e)
        {
            CurrentList = new List<Audio>((PListInfo.DataContext as PlayList).AudioList); //присваиваем текущему списку воспроизведения список песен плейлиста
            SetVisibleMain(); //переключаем панель
            PlayPLAnimate(); //анимируем переключение
            Play.ItemsSource = CurrentList;
        }

        private void RemoveAudioFromPlayList_Click(object sender, MouseButtonEventArgs e)
        {
            if (MessageBox.Show("Удалить этот аудиофайл?", "Подтверждение", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                int ind = playLists.IndexOf(PListInfo.DataContext as PlayList); //получаем индекс песни
                playLists[ind].AudioList.Remove((sender as TextBlock).DataContext as Audio); //удаляем из плейлистов
                playLists[ind].GetTime(); //пересчитываем время
                PListInfo.DataContext = null;
                PListInfo.DataContext = playLists[ind]; //обновляем окно плейлиста
            }
        }

        private void PlayPLAnimate() //анимация кнопки воспроизвести для плейлиста
        {
            DoubleAnimation Anim = new DoubleAnimation();
            Anim.Completed += delegate
            {
                if (CurrentList.Count > 0)
                {
                    ChangeAudio(CurrentList[0]); // после окончания анимации начинаем воспроизведение с первой песни плейлиста
                }
            };
            Anim.From = 0;
            Anim.To = 1;
            Anim.Duration = new Duration(TimeSpan.FromSeconds(1));
            PlayGrid.BeginAnimation(OpacityProperty, Anim);
        }

    }

}