using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp
{
   public  interface ISpeechToText
    {
         Task<string> SpeechToTextAsync();
    }
}
