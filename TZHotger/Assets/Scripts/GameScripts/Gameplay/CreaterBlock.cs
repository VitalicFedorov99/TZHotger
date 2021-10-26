using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreaterBlock : MonoBehaviour
{
    [SerializeField] private DestroyCircle _block;
    [SerializeField] private Defeat _def;
    [SerializeField] private CountScore _countScore;
    [SerializeField] private float x = 1;

    [SerializeField] private int _yMin;
    [SerializeField] private int _yMax;
    [SerializeField] private float _timeCreateBlock = 2f;

    [SerializeField] private int poolCount = 5;
    [SerializeField] private bool autoExpand = false;
    private ObjectPool<DestroyCircle> pool;
    private void Start()
    {
        pool = new ObjectPool<DestroyCircle>(_block, poolCount, transform);
        pool.autoExpand = autoExpand;
        StartCoroutine("Creater");
    }
    public void CreateBlock()
    {
        DestroyCircle instBlock = pool.GetFreeElement();
        instBlock.SetData(_def, _countScore);

        instBlock.gameObject.transform.parent = null;
        int randY = Random.Range(_yMin, _yMax);
        instBlock.transform.position = new Vector3(transform.position.x + x, randY, 0);
    }

    IEnumerator Creater()
    {

        CreateBlock();
        yield return new WaitForSeconds(_timeCreateBlock);
        StartCoroutine("Creater");
    }

    public void SetTimeCreateBlock(float time)
    {
        _timeCreateBlock = time;
    }


}
