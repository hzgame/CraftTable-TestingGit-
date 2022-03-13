using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class num1 : MonoBehaviour
{
    private int id;
    private void OnTriggerEnter2D(Collider2D collision) {//刚体碰撞时触发
        //Debug.Log("collision detected.");
        if (collision.tag.Equals("1")) id = 1;
        if (collision.tag.Equals("2")) id = 2;
        if (collision.tag.Equals("3")) id = 3; 
        if (collision.tag.Equals("4")) id = 4;//此部分用于检测碰撞的部首是什么并传递id，标签只是暂时用来识别部首的，未来会用部首编号来代替
        if (this.gameObject.tag.Equals("#1")) //此部分用于检测部首插入了哪一个空槽
        {
            //Debug.Log("collision#1 detected.");
            GameObject.Find("Crafttable").GetComponent<CraftMethod>().slots[1,1] = id;//传递id值给工作台脚本
            /*Debug.Log(GameObject.Find("Crafttable").GetComponent<CraftMethod>().slots[1, 1]);
            Debug.Log(GameObject.Find("Crafttable").GetComponent<CraftMethod>().slots[1, 2]);
            Debug.Log(GameObject.Find("Crafttable").GetComponent<CraftMethod>().slots[2, 1]);
            Debug.Log(GameObject.Find("Crafttable").GetComponent<CraftMethod>().slots[2, 2]);*/
            //Debug.Log(GameObject.Find("Crafttable").GetComponent<CraftMethod>().a);
            //Debug.Log(GameObject.Find("Crafttable").GetComponent<CraftMethod>().b);
            if (GameObject.Find("Crafttable").GetComponent<CraftMethod>().a >= 1 && GameObject.Find("Crafttable").GetComponent<CraftMethod>().b >= 1)
            {//刷新a,b的值，使slots[a,b]永远在左上的位置，方便计算出相对位置，以下代码同第一个空槽
                GameObject.Find("Crafttable").GetComponent<CraftMethod>().a = 1;
                GameObject.Find("Crafttable").GetComponent<CraftMethod>().b = 1;
                Debug.Log(GameObject.Find("Crafttable").GetComponent<CraftMethod>().a);
                Debug.Log(GameObject.Find("Crafttable").GetComponent<CraftMethod>().b);
            }
        }
        if (this.gameObject.tag.Equals("#2"))
        {
            GameObject.Find("Crafttable").GetComponent<CraftMethod>().slots[1,2] = id;
            if (GameObject.Find("Crafttable").GetComponent<CraftMethod>().a >= 1 && GameObject.Find("Crafttable").GetComponent<CraftMethod>().b >= 2)
            {
                GameObject.Find("Crafttable").GetComponent<CraftMethod>().a = 1;
                GameObject.Find("Crafttable").GetComponent<CraftMethod>().b = 2;
            }
        }
        if (this.gameObject.tag.Equals("#3"))
        {
            GameObject.Find("Crafttable").GetComponent<CraftMethod>().slots[1,3] = id;
            if (GameObject.Find("Crafttable").GetComponent<CraftMethod>().a >= 1 && GameObject.Find("Crafttable").GetComponent<CraftMethod>().b >= 3)
            {
                GameObject.Find("Crafttable").GetComponent<CraftMethod>().a = 1;
                GameObject.Find("Crafttable").GetComponent<CraftMethod>().b = 3;
            }
        }
        if (this.gameObject.tag.Equals("#4"))
        {
            GameObject.Find("Crafttable").GetComponent<CraftMethod>().slots[2,1] = id;
            if (GameObject.Find("Crafttable").GetComponent<CraftMethod>().a >= 2 && GameObject.Find("Crafttable").GetComponent<CraftMethod>().b >= 1)
            {
                GameObject.Find("Crafttable").GetComponent<CraftMethod>().a = 2;
                GameObject.Find("Crafttable").GetComponent<CraftMethod>().b = 1;
            }
        }
        if (this.gameObject.tag.Equals("#5"))
        {
            GameObject.Find("Crafttable").GetComponent<CraftMethod>().slots[2,2] = id;
            if (GameObject.Find("Crafttable").GetComponent<CraftMethod>().a >= 2 && GameObject.Find("Crafttable").GetComponent<CraftMethod>().b >= 2)
            {
                GameObject.Find("Crafttable").GetComponent<CraftMethod>().a = 2;
                GameObject.Find("Crafttable").GetComponent<CraftMethod>().b = 2;
            }
        }
        if (this.gameObject.tag.Equals("#6"))
        {
            GameObject.Find("Crafttable").GetComponent<CraftMethod>().slots[2,3] = id;
            if (GameObject.Find("Crafttable").GetComponent<CraftMethod>().a >= 2 && GameObject.Find("Crafttable").GetComponent<CraftMethod>().b >= 3)
            {
                GameObject.Find("Crafttable").GetComponent<CraftMethod>().a = 2;
                GameObject.Find("Crafttable").GetComponent<CraftMethod>().b = 3;
            }
        }
        if (this.gameObject.tag.Equals("#7"))
        {
            GameObject.Find("Crafttable").GetComponent<CraftMethod>().slots[3,1] = id;
            if (GameObject.Find("Crafttable").GetComponent<CraftMethod>().a >= 3 && GameObject.Find("Crafttable").GetComponent<CraftMethod>().b >= 1)
            {
                GameObject.Find("Crafttable").GetComponent<CraftMethod>().a = 3;
                GameObject.Find("Crafttable").GetComponent<CraftMethod>().b = 1;
            }
        }
        if (this.gameObject.tag.Equals("#8"))
        {
            GameObject.Find("Crafttable").GetComponent<CraftMethod>().slots[3,2] = id;
            if (GameObject.Find("Crafttable").GetComponent<CraftMethod>().a >= 3 && GameObject.Find("Crafttable").GetComponent<CraftMethod>().b >= 2)
            {
                GameObject.Find("Crafttable").GetComponent<CraftMethod>().a = 3;
                GameObject.Find("Crafttable").GetComponent<CraftMethod>().b = 2;
            }
        }
        if (this.gameObject.tag.Equals("#9"))
        {
            GameObject.Find("Crafttable").GetComponent<CraftMethod>().slots[3,3] = id;
            if (GameObject.Find("Crafttable").GetComponent<CraftMethod>().a >= 3 && GameObject.Find("Crafttable").GetComponent<CraftMethod>().b >= 3)
            {
                GameObject.Find("Crafttable").GetComponent<CraftMethod>().a = 3;
                GameObject.Find("Crafttable").GetComponent<CraftMethod>().b = 3;
            }
        }
        
    }

}
