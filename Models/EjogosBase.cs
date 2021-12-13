using System.IO;

namespace EJOGOS.Models
{
    public class EjogosBase
    {

        //criar uma funcao para criar a pasta e o arquivo

        //string path é o parametro da funcao, que tera o caminho
        // para analise
        public void CreateFolderAndFile(string path)
        {
            // pasta / arquivo.csv;

            string folder = path.Split('/')[0];
            string file = path.Split('/')[1];

            // se não existir cria a pasta
            if (!Directory.Exists(folder)
            {
                Directory.CreateDirectory(folder);
            }

            if (!File.Exists(file))
            {
                File.Create(path);
            }
        }

    }
}
