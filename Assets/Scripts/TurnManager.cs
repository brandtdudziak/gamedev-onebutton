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
    public GameObject checkMark;
    public GameObject rock;
    public GameObject paper;
    public GameObject scissor;

    private GameObject clone1;
    private GameObject clone2;
    private GameObject cMark1;
    private GameObject cMark2;
    public int benchStartLength = 6;
    private int benchLeft;
    private int benchRight;
    private int playerPosition;

    // Start is called before the first frame update
    void Start()
    {
        benchLeft = 0;
        benchRight = benchStartLength;
        playerPosition = benchStartLength / 2;
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
                    PlaceCheckMark(0);
                }
                if (Input.GetKeyDown(KeyCode.S))
                {
                    state = 2;
                    player1Input = 2;
                    PlaceCheckMark(0);
                }
                if (Input.GetKeyDown(KeyCode.D))
                {
                    state = 2;
                    player1Input = 3;
                    PlaceCheckMark(0);
                }
                if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    state = 1;
                    player2Input = 1;
                    PlaceCheckMark(1);
                }
                if (Input.GetKeyDown(KeyCode.DownArrow))
                {
                    state = 1;
                    player2Input = 2;
                    PlaceCheckMark(1);
                }
                if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    state = 1;
                    player2Input = 3;
                    PlaceCheckMark(1);
                }
                break;
            case 1:
                if (Input.GetKeyDown(KeyCode.A))
                {
                    state = 3;
                    player1Input = 1;
                    PlaceCheckMark(0);
                }
                if (Input.GetKeyDown(KeyCode.S))
                {
                    state = 3;
                    player1Input = 2;
                    PlaceCheckMark(0);
                }
                if (Input.GetKeyDown(KeyCode.D))
                {
                    state = 3;
                    player1Input = 3;
                    PlaceCheckMark(0);
                }
                break;
            case 2:
                if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    state = 3;
                    player2Input = 1;
                    PlaceCheckMark(1);
                }
                if (Input.GetKeyDown(KeyCode.DownArrow))
                {
                    state = 3;
                    player2Input = 2;
                    PlaceCheckMark(1);
                }
                if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    state = 3;
                    player2Input = 3;
                    PlaceCheckMark(1);
                }
                break;
            case 3:
                RpsResolve();
                StartCoroutine(DisplayResult());
                state = 4;
                break;
            case 4:
                break;
        }
    }

    void RpsResolve()
    {
        if (player1Input == 1 && player2Input == 1)
        {
            //Draw
            //Check for win
            PlaceRPS(player1Input, player2Input);
            //state = 0;
        }
        else if (player1Input == 1 && player2Input == 2)
        {
            //Player 2 Wins
            Player2Win();
            //Check for win
            PlaceRPS(player1Input, player2Input);
            //state = 0;
        }
        else if (player1Input == 1 && player2Input == 3)
        {
            //Player 1 Wins
            Player1Win();
            //Check for win
            PlaceRPS(player1Input, player2Input);
            //state = 0;
        }
        else if (player1Input == 2 && player2Input == 1)
        {
            //Player 1 Wins
            Player1Win();
            //Check for win
            PlaceRPS(player1Input, player2Input);
            //state = 0;
        }
        else if (player1Input == 2 && player2Input == 2)
        {
            //Draw
            //Check for win
            PlaceRPS(player1Input, player2Input);
            //state = 0;
        }
        else if (player1Input == 2 && player2Input == 3)
        {
            //Player 2 Wins
            Player2Win();
            //Check for win
            PlaceRPS(player1Input, player2Input);
            //state = 0;
        }
        else if (player1Input == 3 && player2Input == 1)
        {
            //Player 2 Wins
            Player2Win();
            //Check for win
            PlaceRPS(player1Input, player2Input);
            //state = 0;
        }
        else if (player1Input == 3 && player2Input == 2)
        {
            //Player 1 Wins
            Player1Win();
            //Check for win
            PlaceRPS(player1Input, player2Input);
            //state = 0;
        }
        else if (player1Input == 3 && player2Input == 3)
        {
            //Draw
            //Check for win
            PlaceRPS(player1Input, player2Input);
            //state = 0;
        }
    }

    void PlaceCheckMark(int side)
    {
        //0 = left, 1 = right
        if(side == 0)
        {
            cMark1 = Instantiate(checkMark, new Vector3(-6, -4, 0), new Quaternion(0, 0, 0, 0));
        }
        else
        {
            cMark2 = Instantiate(checkMark, new Vector3(6, -4, 0), new Quaternion(0, 0, 0, 0));
        }
       
    }

    void PlaceRPS(int left, int right)
    {
        switch (left)
        {
            case 1:
                clone1 = Instantiate(rock, new Vector3(-2, -4, 0), new Quaternion(0, 0, 0, 0));
                break;
            case 2:
                clone1 = Instantiate(paper, new Vector3(-2, -4, 0), new Quaternion(0, 0, 0, 0));
                break;
            case 3:
                clone1 = Instantiate(scissor, new Vector3(-2, -4, 0), new Quaternion(0, 0, 0, 0));
                break;
        }
        switch (right)
        {
            case 1:
                clone2 = Instantiate(rock, new Vector3(2, -4, 0), new Quaternion(0, 0, 0, 0));
                break;
            case 2:
                clone2 = Instantiate(paper, new Vector3(2, -4, 0), new Quaternion(0, 0, 0, 0));
                break;
            case 3:
                clone2 = Instantiate(scissor, new Vector3(2, -4, 0), new Quaternion(0, 0, 0, 0));
                break;
        }
    }

    IEnumerator DisplayResult()
    {
        yield return new WaitForSeconds(3);
        Destroy(clone1);
        Destroy(clone2);
        Destroy(cMark1);
        Destroy(cMark2);
        state = 0;
    }

    void Player1Win()
    {
        playerOne.GetComponent<PlayerMovement>().MoveRight();
        playerTwo.GetComponent<PlayerMovement>().MoveRight();
        playerPosition += 1;
        CheckWin();
    }

    void Player2Win()
    {
        playerOne.GetComponent<PlayerMovement>().MoveLeft();
        playerTwo.GetComponent<PlayerMovement>().MoveLeft();
        playerPosition -= 1;
        CheckWin();
    }

    void CheckWin()
    {
        // if player 1 < bench left
            // player 1 loses
        // if player 2 > bench right
            // player 2 loses
    }
}
