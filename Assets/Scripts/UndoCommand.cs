using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Undo : MonoBehaviour
{
   GameControls inputAction;

    static Queue<ICommand> commandBuffer;

    static List<ICommand> commandHistory;
    static int counter;

    // Start is called before the first frame update
    void Start()
    {
        inputAction.Player.Undo.performed += cntxt => UndoCommand();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UndoCommand()
    {
        if (commandBuffer.Count <= 0)
        {
            if (counter > 0)
            {
                counter--;
                commandHistory[counter].Undo();
                commandHistory[counter].Undo();
                commandHistory[counter].Undo();
                commandHistory[counter].Undo();
                commandHistory[counter].Undo();
                commandHistory[counter].Undo();
                commandHistory[counter].Undo();
            }
        }
    }
}
