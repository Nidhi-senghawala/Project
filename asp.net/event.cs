
public delegate string MyDel(string str);
	
   public class EventProgram 
   {
      public event MyDel MyEvent;
		
      public EventProgram() 
      {
         this.MyEvent += new MyDel(this.WelcomeUser);
      }
      public string WelcomeUser(string username) 
      {
         return "Welcome " + username;
      }
      
   }
   

/*
public class p
{
    // event handler
    static void bl_ProcessCompleted()
    {
        Console.WriteLine("Process Completed!");
    }


public delegate void Notify();  // delegate
                    
public class ProcessBusinessLogic
{
    public event Notify ProcessCompleted; // event

        internal void StartProcess()
        {
            throw new NotImplementedException();
        }
    }
}
*/
