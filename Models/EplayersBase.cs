using System.Collections.Generic;
using System.IO;

namespace E_players_AspNetCore.Models
{
    public class EplayersBase
    {
        public void CreateFolderAndFile(string _path){

            string folder   = _path.Split("/")[0];
            string file     = _path.Split("/")[1];

            if(!Directory.Exists(folder)){
                Directory.CreateDirectory(folder);
            }

            if(!File.Exists(_path)){
                File.Create(_path);
            }
        }

        public List<string> ReadAllLinesCSV(string path){

            List<string> linhas = new List<string>(); 
            
            //using -> responsável por abrir e fechar o arquivo automaticamente 1
            using(StreamReader file = new StreamReader(path))
            {
                string linha;

                //percorrer as linhas com um laço while
                while((linha = file.ReadLine()) !=null)
                {
                    linhas.Add(linha);
                }
            }

            return linhas;
        }

        public void RewriteCSV(string path, List<string> linhas)
        {

        //StreamWriter  -> Escrever os dados em um arquivo 
        using(StreamWriter output = new StreamWriter(path))
        {
            foreach (var item in linhas)
            {
                output.Write(item +'\n');
            }
        }

        }
        
    }

}