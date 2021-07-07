using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : Singleton<GameController>
{   
    public Transform blocksHolder;

    private List<GameObject> blocks;
    // Start is called before the first frame update
    void Start()
    {
        blocks = new List<GameObject>();
        for (var i = 0; i < blocksHolder.childCount; i++)
        {
            GameObject blockGO = blocksHolder.GetChild(i).gameObject;
            if (blockGO.CompareTag(Constants.Tags.BlockTypeA) || blockGO.CompareTag(Constants.Tags.BlockTypeB))
            {
                blocks.Add(blockGO);
            }
        }
    }

    private bool IsCorrect()
    {
        int correctCount = 0;
        foreach (var block in blocks)
        {
            if (block.GetComponent<BlockController>().IsCorrect())
            {
                correctCount++;
            }
        }

        return correctCount == blocks.Count;
    }

    public void CheckBoard()
    {
        if (IsCorrect())
        {
            Debug.LogError("Win: Game over");
        }
        else
        {
            Debug.LogError("Not valid");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
