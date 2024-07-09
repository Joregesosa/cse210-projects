using System; 

/* ReflectingActivity
Run() : void
GetRandomPrompt() : string
GetRandomQuestion() : string
DisplayPrompt() : void
DisplayQuestions() : void */

class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    ReflectingActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        ShowSpinner();
        ShowCountDown();
        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(0, _prompts.Count);
   
    }

    public void GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(0, _questions.Count);
 
    }

    public void DisplayPrompt()
    {
 
    }

    public void DisplayQuestions()
    {
         
    }
}