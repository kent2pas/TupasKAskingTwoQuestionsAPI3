//Kent Tupas
//10/25/2022
//Asking Two Questions
//Peer Review: Elizar Garcia, code works great. i really like the layout of how the questions are asked and followed up with. The code shows up on postman with no problem. Good job sir!

using Microsoft.AspNetCore.Mvc;

namespace TupasKAskingTwoQuestionsAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class AskingTwoQuestionController : ControllerBase
{
 [HttpGet]
 [Route("Questions/{name}/{adj}/{number}")] 

 public string Questions(string name, string adj, string number)
 {
    return $"Hey {name} \nHow are you feeling? \n{adj} \nSoooo what time did you wake up? \n{number} \nThats cool {name} waking up at {number}";
 }
}
