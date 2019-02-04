using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    private int state = 0;
    //Rock = 1, Paper = 2, Scissor = 3
    private int player1Input = 0;
    private int player2Input = 0;
    public GameObject playerOne;
    public GameObject playerTwo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch(state)
        {
            case 0:
                if(Input.GetKeyDown(KeyCode.A))
                {
                    state = 2;
                    player1Input = 1;
                }
                if (Input.GetKeyDown(KeyCode.S))
                {
                    state = 2;
                    player1Input = 2;
                }
                if (Input.GetKeyDown(KeyCode.D))
                {
                    state = 2;
                    player1Input = 3;
                }
                if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    state = 1;
                    player2Input = 1;
                }
                if (Input.GetKeyDown(KeyCode.DownArrow))
                {
                    state = 1;
                    player2Input = 2;
                }
                if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    state = 1;
                    player2Input = 3;
                }
                break;
            case 1:
                if (Input.GetKeyDown(KeyCode.A))
                {
                    state = 3;
                    player1Input = 1;
                }
                if (Input.GetKeyDown(KeyCode.S))
                {
                    state = 3;
                    player1Input = 2;
                }
                if (Input.GetKeyDown(KeyCode.D))
                {
                    state = 3;
                    player1Input = 3;
                }
                break;
            case 2:
                if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    state = 3;
                    player2Input = 1;
                }
                if (Input.GetKeyDown(KeyCode.DownArrow))
                {
                    state = 3;
                    player2Input = 2;
                }
                if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    state = 3;
                    player2Input = 3;
                }
                break;
            case 3:
                rpsResolve();
                break;
        }
    }

    void rpsResolve()
    {
        if (player1Input == 1 && player2Input == 1)
        {
            //Draw
            //Check for win
            state = 0;
        }
        else if (player1Input == 1 && player2Input == 2)
        {
            //Player 2 Wins
            playerOne.GetComponent<PlayerMovement>().MoveLeft();
            playerTwo.GetComponent<PlayerMovement>().MoveLeft();
            //Check for win
            state = 0;
        }
        else if (player1Input == 1 && player2Input == 3)
        {
            //Player 1 Wins
            playerOne.GetComponent<PlayerMovement>().MoveRight();
            playerTwo.GetComponent<PlayerMovement>().MoveRight();
            //Check for win
            state = 0;
        }
        else if (player1Input == 2 && player2Input == 1)
        {
            //Player 1 Wins
            playerOne.GetComponent<PlayerMovement>().MoveRight();
            playerTwo.GetComponent<PlayerMovement>().MoveRight();
            //Check for win
            state = 0;
        }
        else if (player1Input == 2 && player2Input == 2)
        {
            //Draw
            //Check for win
            state = 0;
        }
        else if (player1Input == 2 && player2Input == 3)
        {
            //Player 2 Wins
            playerOne.GetComponent<PlayerMovement>().MoveLeft();
            playerTwo.GetComponent<PlayerMovement>().MoveLeft();
            //Check for win
            state = 0;
        }
        else if (player1Input == 3 && player2Input == 1)
        {
            //Player 2 Wins
            playerOne.GetComponent<PlayerMovement>().MoveLeft();
            playerTwo.GetComponent<PlayerMovement>().MoveLeft();
            //Check for win
            state = 0;
        }
        else if (player1Input == 3 && player2Input == 2)
        {
            //Player 1 Wins
            playerOne.GetComponent<PlayerMovement>().MoveRight();
            playerTwo.GetComponent<PlayerMovement>().MoveRight();
            //Check for win
            state = 0;
        }
        else if (player1Input == 3 && player2Input == 3)
        {
            //Draw
            //Check for win
            state = 0;
        }
    }
}
