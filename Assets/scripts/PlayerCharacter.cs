using UnityEngine;

public class PlayerCharacter : MonoBehaviour

{ //Variable will go first

    [SerializeField] private int attack = 10;
    [SerializeField] private int health = 100;
    [SerializeField] private int level = 1;

    
    




    //Method will go underneath here



    // Start is called before the first frame update
     private void Start()
    {
        attack = 10;
        health = 100;
        level = 1;
  
    }

    // Update is called once per frame
  private  void Update()
    {
        
    }
}
