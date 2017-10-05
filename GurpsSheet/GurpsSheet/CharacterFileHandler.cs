using System.IO;

namespace GurpsSheet
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
