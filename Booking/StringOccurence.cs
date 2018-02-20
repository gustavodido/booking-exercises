using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Booking
{
    [TestClass]
    public class StringOccurences
    {
        [TestMethod]
        public void Occurence()
        {
            const string stream = "hellohellhelhellelloelasnqlhellaoahelelhelloheohlelhoeheohleolhehelhhellooelhhelhhhelloeo.";
            const string search = "hello";

            int word = 0;
            string buffer = string.Empty;
            
            for (int i = 0, pos = 0; i < stream.Length; i++)
            {
                buffer += stream[i];

                if (buffer[pos] != search[pos])
                {
                    // Need to come back in the buffer to reprocess the last letter as the begining (hhello)
                    if (buffer.Length > 1)
                        i--;

                    // Restart the word position
                    pos = 0;
                    buffer = string.Empty;
                }
                else
                    pos++;

                if (buffer != search) continue;

                word++;
                buffer = string.Empty;
                pos = 0;
            }

            Assert.AreEqual(word, 4);
        }
    }
}
