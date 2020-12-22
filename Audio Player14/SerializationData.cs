using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows;

namespace Audio_Player
{
    public partial class MainWindow : Window
    {
        private void DeserializeData()
        {
            //считываем данные
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("P_S.dat", FileMode.OpenOrCreate))
            {
                if (fs.Length != 0)
                    Paths = (List<string>)formatter.Deserialize(fs);
            }
            ListPaths.ItemsSource = new List<string>(Paths);

            using (FileStream fs = new FileStream("P_List.dat", FileMode.OpenOrCreate))
            {
                if (fs.Length != 0)
                    mainPL.AudioList = (List<Audio>)formatter.Deserialize(fs);
            }
            //обновляем окна
            ListPaths.ItemsSource = new List<string>(Paths);
            Play.ItemsSource = new List<Audio>(mainPL.AudioList);
        }

        private void SerializeData()
        {
            //сохраняем пути, главный плейлист и плейлисты
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("P_S.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, Paths);
            }
            using (FileStream fs = new FileStream("P_List.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, mainPL.AudioList);
            }
        }

    }
}