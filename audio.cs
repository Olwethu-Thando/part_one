using System;
using System.Media;

namespace part_one
{
    public class audio
    {
        string path = AppDomain.CurrentDomain.BaseDirectory;
        public audio()
        {// start of consturctor 
            // call voice method 
            voice();
        }// end of constructor 
        private void voice()
        {// START Of METHOD 
            // get the full path replace of debug\ bin \
            string fullpath = path.Replace(@"bin\Debug\", "");
            // paly the sound 
            string joined_path = fullpath + "greet.wav";

            // create an instance foe the sound player class 
            SoundPlayer voice_play = new SoundPlayer(joined_path);
            // LOAD THE AUDIO 
            voice_play.Load();
            // play till the end 
            voice_play.PlaySync();

        }
    }
}