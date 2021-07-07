using System.Linq;
using UnityEngine;

public class BlockController : MonoBehaviour
{
    public BlockType type;
    public Vector2 gridPosition;
    public Sprite spriteDeactivated;
    public Sprite spriteActivated;
    public BlockAngle angleInitial;
    public BlockAngle[] anglesCorrect;
    public BlockAngle angleCurrent;

    void Start()
    {
        transform.rotation = Quaternion.Euler(0, 0, Constants.AngleDictionary[angleInitial]);
        angleCurrent = angleInitial;
    }

    public bool IsCorrect()
    {
        return  anglesCorrect.Contains(angleCurrent);
    }

    private void OnMouseDown()
    {
        // 1. Rotate
        transform.Rotate(0, 0, Constants.ANGLE_90);
        // 2. Set current angle   
        angleCurrent = Constants.AngleDictionaryNext[angleCurrent];
        if (IsCorrect())
        {
            Debug.LogError("Correct");
        }
        // 3. Check the correction of all connector
        
        // 4. Check the correction of all board
        GameController.Instance.CheckBoard();
    }
}