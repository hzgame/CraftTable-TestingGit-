using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class num1 : MonoBehaviour
{
    private int id;
    private void OnTriggerEnter2D(Collider2D collision) {//������ײʱ����
        //Debug.Log("collision detected.");
        if (collision.tag.Equals("1")) id = 1;
        if (collision.tag.Equals("2")) id = 2;
        if (collision.tag.Equals("3")) id = 3; 
        if (collision.tag.Equals("4")) id = 4;//�˲������ڼ����ײ�Ĳ�����ʲô������id����ǩֻ����ʱ����ʶ���׵ģ�δ�����ò��ױ��������
        if (this.gameObject.tag.Equals("#1")) //�˲������ڼ�ⲿ�ײ�������һ���ղ�
        {
            //Debug.Log("collision#1 detected.");
            GameObject.Find("Crafttable").GetComponent<CraftMethod>().slots[1,1] = id;//����idֵ������̨�ű�
            /*Debug.Log(GameObject.Find("Crafttable").GetComponent<CraftMethod>().slots[1, 1]);
            Debug.Log(GameObject.Find("Crafttable").GetComponent<CraftMethod>().slots[1, 2]);
            Debug.Log(GameObject.Find("Crafttable").GetComponent<CraftMethod>().slots[2, 1]);
            Debug.Log(GameObject.Find("Crafttable").GetComponent<CraftMethod>().slots[2, 2]);*/
            //Debug.Log(GameObject.Find("Crafttable").GetComponent<CraftMethod>().a);
            //Debug.Log(GameObject.Find("Crafttable").GetComponent<CraftMethod>().b);
            if (GameObject.Find("Crafttable").GetComponent<CraftMethod>().a >= 1 && GameObject.Find("Crafttable").GetComponent<CraftMethod>().b >= 1)
            {//ˢ��a,b��ֵ��ʹslots[a,b]��Զ�����ϵ�λ�ã������������λ�ã����´���ͬ��һ���ղ�
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
