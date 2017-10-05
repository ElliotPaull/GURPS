using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GuipsSheet;

namespace GURPSSheetTest
{
    [TestClass]
    public class LegalityTests
    {
        [TestMethod]
        public void saving_a_character_saves_its_name()
        {
            using (var memoryStream = new MemoryStream())
            {
                //given
                var name = "merlin";
                var legality = new Legality();

                //when
                legality.SaveCharacter(memoryStream, name);

                //then
                memoryStream.Position = 0;
                var Reader = new StreamReader(memoryStream);
                var actualCharacterData = Reader.ReadToEnd();
                var containsName = actualCharacterData.Contains(name);
                Assert.IsTrue(containsName, actualCharacterData);
            }
        }
    }
}
