namespace Constructors
{
    internal class Program
    {
        Quiz quiz = new Quiz(10);

        static void Main(string[] args)
        {
            Program program = new Program();

           program.Run();
        }
        internal void Run()
        {
            
            
            QuizVraag quizVraag = new QuizVraag("Hier komt de vraag...", "Hier komt het antwoord...");
            
            quiz.VoegVraagToeOpIndex(0, quizVraag);
            
            quiz.VoegVraagToeOpIndex(1, quizVraag);

            QuizVraag quizVraag1 = new QuizVraag("Hier komt de tweede vraag...", "Hier komt het tweede antwoord...");

            quiz.VoegVraagToeOpIndex(2, quizVraag);

            QuizVraag quizVraag2 = new QuizVraag("Hier komt de derde vraag...", "Hier komt het derde antwoord...");

            quiz.VoegVraagToeOpIndex(3, quizVraag);

            QuizVraag quizVraag3 = new QuizVraag("Hier komt de vierde vraag...", "Hier komt het vierde antwoord...");

            quiz.VoegVraagToeOpIndex(4, quizVraag);

            QuizVraag quizVraag4 = new QuizVraag("Hier komt de vijfde vraag...", "Hier komt het vijfde antwoord...");

            quiz.VoegVraagToeOpIndex(5, quizVraag);

            QuizVraag quizVraag5 = new QuizVraag("Hier komt de zesde vraag...", "Hier komt het zevende antwoord...");

            quiz.VoegVraagToeOpIndex(6, quizVraag);

            QuizVraag quizVraag6 = new QuizVraag("Hier komt de zevende vraag...", "Hier komt het zevende antwoord...");

            quiz.VoegVraagToeOpIndex(7, quizVraag);

            QuizVraag quizVraag7 = new QuizVraag("Hier komt de achtste vraag...", "Hier komt het achtste antwoord...");

            quiz.VoegVraagToeOpIndex(8, quizVraag);

            QuizVraag quizVraag8 = new QuizVraag("Hier komt de negende vraag...", "Hier komt het negende antwoord...");

            quiz.VoegVraagToeOpIndex(9, quizVraag);

            QuizVraag quizVraag9 = new QuizVraag("Hier komt de tiende vraag...", "Hier komt het tiende antwoord...");

            for (int i = 0; i < quiz.vragen.Length; i++)
            {

            }

            return;
        }
        


        //Het gaat écht niet.
    }
}
