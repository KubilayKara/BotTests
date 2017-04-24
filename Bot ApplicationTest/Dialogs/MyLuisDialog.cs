using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Bot_ApplicationTest.Dialogs
{
    
    [LuisModel("1de929c1-b424-46a4-a644-edd3323b39a7","ddda67903b36493696219497400f1b97")]
    [Serializable]
    public class MyLuisDialog:LuisDialog<object>
    {

        public MyLuisDialog()
        {

        }

        [LuisIntent("Greetings")]
        public async Task Greeting (IDialogContext context, LuisResult result)
        {

            await context.PostAsync("oo kimler gelmiş");
            context.Wait(MessageReceived);
        }

        [LuisIntent("")]
        public async Task None(IDialogContext context, LuisResult result)
        {
            await context.PostAsync("I have no idea what you are talking about.");
            context.Wait(MessageReceived);
        }
    }
}