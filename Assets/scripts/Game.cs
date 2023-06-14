using UnityEngine;

public class Game : MonoBehaviour

{ //Variable will go first

    [SerializeField] private int playerAttack = 10;
    [SerializeField] private int playerHealth = 100;
    [SerializeField] private int playerLevel = 1;

    [SerializeField] private int enemyAttack = 20;

    //Method will go underneath here



    // Start is called before the first frame update
    void Start()
    {
        playerAttack = 10;
        playerHealth = 100;
        playerLevel = 1;
  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
