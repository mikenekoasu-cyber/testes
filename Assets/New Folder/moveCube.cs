using UnityEngine;

public class moveCube : MonoBehaviour
{
    // private enum selection{
    //     Attack,
    //     Heal,
    // }

    // private int a = 0;
    // private int targetHp = 0;
    // private int playerHp = 0;

    // void Attack(target,damageAmount){
    //     Debug.Log(selection.Attack + "を選択");
    //     Debug.Log(Damage(target, damageAmount) + "ダメージ与えました");
    // }

    // void Heal(){
    //     Debug.Log(selection.Heal + "を選択");
    // }

    // public int Damage(target, damageAmount){
    //     int targetHpBefore = target;
    //     target -= damageAmount;
    //     return targetHpBefore - target;
    // }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("ゲームが始まりました！");
        GameObject[] cubes = GameObject.FindGameObjectsWithTag("Player");
        foreach(GameObject cube in cubes){
            cube.GetComponent<Renderer>().material.color = Color.red;
        }
        // string[] names = {"田中","鈴木","佐藤"};
        // foreach(string name in names){
        //     Debug.Log(name);
        // }
        // Debug.Log(CalculateHpRatio(20,30));
        // Debug.Log(CanBuyItem(20,30));
        // Debug.Log(CanBuyItem(40,30));
    }

    // Update is called once per frame
    void Update()
    {


        // if(Input.GetKey(KeyCode.W)){
        //     a = (int)selection.Attack;
        // }else if(Input.GetKey(KeyCode.S)){
        //     a = (int)selection.Heal;
        // }else if(Input.GetKey(KeyCode.Space)){
        //     switch(a){
        //         case 0:Attack();
        //         break;
        //         case 1:Heal();
        //         break;
        //         default:Debug.Warn("不明な行動です");
        //         break;
        //     }
        // }


        // Debug.Log("ts");
        // transform.Translate(1.0f * Time.deltaTime, 0, 0);
        // Debug.Log("ts2");
        // transform.Rotate(0, 1.0f * Time.deltaTime, 0);
        // int x = 10;
        // float y = 2.5f;
        // string z = "x + y = ";
        // Debug.Log(x);
        // Debug.Log(y);
        // Debug.Log(z + (x + y));
        // bool w = x == 10;
        // Debug.Log(w);
        // //w = x != 10;
        // Debug.Log(w);
        // if(w){
        //     Debug.Log("wはtrueです");
        // }else{
        //     Debug.Log("wはfalseです");
        // }
        // for(int i = 0; i < 5; i++){
        //     Debug.Log(i);
        // }
        // while(x > 0){
        //     if(x == 5){
        //         x--;
        //         continue;
        //     }else if(x == 3){
        //         break;
        //     }
        //     Debug.Log(x);
        //     x--;
        // }
    // }
    // public float CalculateHpRatio(float HP,float maxHP){
    //         return HP / maxHP;
    //     }

    // public bool CanBuyItem(int money,int price){
    //         return money >= price;
    //     }
    }
}