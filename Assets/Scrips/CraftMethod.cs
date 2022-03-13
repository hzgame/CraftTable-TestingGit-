using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftMethod : MonoBehaviour
{
    public GameObject huo;
    public int[,] slots = new int [10,10];//�����ղ�λ�������
    public int a = 10;
    public int b = 10;//a,b���ڴ洢ĳ���ֵ��׸���ⲿ��λ��
    private bool condition = false; //Ϊ��������ֻ����һ��

    void Update()
    {
        if (!condition)
        {
            if (slots[a, b] == 1 && slots[a, b + 1] == 2 && slots[a + 1, b] == 3 && slots[a + 1, b + 1] == 4)
            {//���в��׵����λ�ô�ɺϳ����֡��𡱵�����
                craft_huo();
            }
            condition = true;//�ı�����ʹ���ֲ�������
        }
    }

    private void craft_huo() {//�ϳ����֡���
        Vector3 pos = transform.position + new Vector3(9, 1, 0);
        Instantiate(huo, pos, transform.rotation);
    }
}
