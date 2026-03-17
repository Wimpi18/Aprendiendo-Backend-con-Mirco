using Chain_of_Responsability_Handler_Levels;

var level1 = new Level1Handler();
var level2 = new Level2Handler();

level1.SetSuccessor(level2);

level1.HandleRequest(3);
