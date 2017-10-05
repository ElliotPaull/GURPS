using System.IO;

namespace GuipsSheet
{
    public class CharacterFileHandler
    {
        public void SaveCharacter(Stream stream, string name)
        {
            var writer = new StreamWriter(stream);
            writer.Write(name);
            writer.Flush();
        }
    }
}
