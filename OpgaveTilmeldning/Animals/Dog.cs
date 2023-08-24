using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace OpgaveTilmeldning.Animals
{
    internal class Dog : Animal
    {
        public override void MakeSound()
        {
            string myCurrentDer = System.IO.Directory.GetCurrentDirectory();
            string appDir = System.IO.Path.Combine(myCurrentDer, "Animals");
            appDir = System.IO.Path.Combine(appDir, "dog.wav");
            PlaySound(appDir);
        }
        public void PlaySound(string soundPath)
        {

            SoundPlayer soundPlayer = new SoundPlayer();
            soundPlayer.SoundLocation= soundPath;
            soundPlayer.Play();
        }
    }
}
