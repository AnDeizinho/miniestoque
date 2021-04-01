using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace MINIESTOQUE.ENTIDADE
{
    [Serializable]
    public class Model
    {
        public List<Item> CarregaItensSalvos()
        {
            FileStream FS = new FileStream("itens.data", FileMode.OpenOrCreate);
            try
            {

                BinaryFormatter Bf = new BinaryFormatter();
                List<Item> item = (List<Item>)Bf.Deserialize(FS);
                FS.Close();
                return item;

            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message.ToString());
                FS.Close();
                return new List<Item>();
            }
            finally
            {
                FS.Close();
            }
            
        }
        public bool SalvarItens(List<Item> lista )
        {
            FileStream FS = new FileStream("itens.data", FileMode.OpenOrCreate);
            try
            {

                BinaryFormatter Bf = new BinaryFormatter();
                Bf.Serialize(FS, lista);
                FS.Close();
                return true;

            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message.ToString());
                FS.Close();
                return false;
            }
            finally
            {
                FS.Close();
            }
            
        }
        
    }
}
