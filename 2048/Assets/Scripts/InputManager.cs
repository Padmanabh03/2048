using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MoveDirection
{
    Left,Right,Up,Down
}

public class InputManager : MonoBehaviour
{

    private GameManage gm;

    private void Awake()
    {
        gm = GameObject.FindObjectOfType<GameManage>();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gm.State == GameState.Playing)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                gm.Move(MoveDirection.Right);
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                gm.Move(MoveDirection.Left);
            }
            else if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                gm.Move(MoveDirection.Up);  
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                gm.Move(MoveDirection.Down);
            }
        }
    }    
}
