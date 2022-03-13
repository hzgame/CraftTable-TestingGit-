using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftMethod : MonoBehaviour
{
    public GameObject huo;
    public int[,] slots = new int [10,10];//创建空槽位用来检测
    public int a = 10;
    public int b = 10;//a,b用于存储某个字的首个检测部首位置
    private bool condition = false; //为了让文字只生成一次

    void Update()
    {
        if (!condition)
        {
            if (slots[a, b] == 1 && slots[a, b + 1] == 2 && slots[a + 1, b] == 3 && slots[a + 1, b + 1] == 4)
            {//所有部首的相对位置达成合成文字“火”的条件
                craft_huo();
            }
            condition = true;//改变条件使文字不再生成
        }
    }

    private void craft_huo() {//合成文字“火”
        Vector3 pos = transform.position + new Vector3(9, 1, 0);
        Instantiate(huo, pos, transform.rotation);
    }
}
