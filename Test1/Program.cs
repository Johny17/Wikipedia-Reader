using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Speech.Synthesis;
using System.Speech.Recognition;

namespace Test1
{
    static class Program
    {

        static void Main(string[] args)

        {

            //RecognitionCore core = new RecognitionCore();

            //SpeechSynthesizer synth = new SpeechSynthesizer();

            //CommandBuilder cmdBuilder = new CommandBuilder();

            //ChoiceSet choices = new ChoiceSet();

            //choices
            //        .Add("google");
            //        .Add("youtube");

            //cmdBuilder.Text("search")
            //    .choices("search_provider", choices)
            //    .Text("for")
            //    .Any()
            //    .Handle(context =>
            //    {
            //    var words = context.Phrase.Words.Skip(3));

            //    switch (choices Value)
            //        {
            //    case "youtube":
            //    searchgoogle(searchTerm);
            //    break;
            //}


           

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Datareading());

        }

        private static void Add(string v)
        {
            throw new NotImplementedException();
        }
    }
}
