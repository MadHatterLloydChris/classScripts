using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Theology101: Classes
{
    //public List<Classes> requiredClasseses;
    // Start is called before the first frame update
    public float coolDown;

    public override void learnClasses()
    {
        playerscript.takenClassesesList.Add(this);
        onPlayer = true;

    }
    public override string classSynopsis()
    {
        return "The fitness grand pacer test...";
    }

    void Start()
    {

    }
    public override bool prereqCheck(Player playerScript)
    {
        return true;
    }

    // Update is called once per frame
    void Update()
    {
        if (onPlayer)
        {
            if (playerscript)
            {
                classAction();
            }
            else {
                Debug.Log("oops, I lost you there");
            }
        }
    }
    public override string save()
    {
        string returner;
        returner = "";
        return returner;
    }
    public override void classAction()
    {
        if (teacher == "Janna")
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                if (this.coolDown < 0)
                {
                    playerscript.heal(5);
                    coolDown = 5;
                }
            }
        }
        else {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                if (this.coolDown < 0)
                {
                    playerscript.heal(5);
                    coolDown = 5;
                }
            }
        }

        if (this.coolDown >= 0)
        {
            coolDown -= Time.deltaTime;
        }
    }
    public override List<string> resetTeachers() {
        
        List<string> returner = new List<string>();
        int value = Random.Range(0, 100);
        if (value < 40)
            returner.Add("AOE");
        value = Random.Range(0, 100);
        if (value < 35)
            returner.Add("DPS");
        value = Random.Range(0, 100);
        if (value < 35)
            returner.Add("ZON");
        value = Random.Range(0, 100);
        if (value < 99)
            returner.Add("Joe");
        return returner;
    }
}
