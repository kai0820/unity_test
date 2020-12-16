using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Rocker : ScrollRect
{
    protected float mRadius = 0f;
    private PlayerController controller;

    protected override void Start()
    {
        base.Start();
        //计算摇杆块的半径
        mRadius = (transform as RectTransform).sizeDelta.x * 0.5f;
        controller = GameObject.FindObjectOfType<PlayerController>();
    }

    public override void OnDrag(PointerEventData eventData)
    {
        base.OnDrag(eventData);
        print("=============OnDrag");
        var contentPostion = this.content.anchoredPosition;
        if (contentPostion.magnitude > mRadius)
        {
            contentPostion = contentPostion.normalized * mRadius;
            SetContentAnchoredPosition(contentPostion);
        }
        // //Debug.Log(contentPostion);
        // //this.gameObject.getch
        // GameObject role = GameObject.Find("Jammo_Player");
        // //Debug.Log(role.name);
        // //Debug.Log(contentPostion.normalized);
        // //role.transform.rotation = Quaternion.LookRotation(new Vector3(contentPostion.x, contentPostion.y, 0));

        // 旋转注视
        Quaternion qua = Quaternion.LookRotation(new Vector3(contentPostion.normalized.x, 0, contentPostion.normalized.y));
        // // 人物旋转
        // role.transform.rotation = qua;
        // // 人物移动
        // role.transform.Translate(new Vector3(contentPostion.normalized.x, 0, contentPostion.normalized.y)*Time.deltaTime*10, Space.World);
        // //print(role.transform.position);

        // //moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
        // //moveDirection = transform.TransformDirection(moveDirection);
        // //moveDirection = moveDirection * speed;
        controller.setMovingFlag(true);
        controller.setQua(qua);
        controller.setTrans(new Vector3(contentPostion.normalized.x, 0, contentPostion.normalized.y));
    }

    public override void OnScroll(PointerEventData eventData)
    {
        base.OnScroll(eventData);
        print("=============OnScroll");
    }

    public override void OnBeginDrag(PointerEventData eventData)
    {
        base.OnBeginDrag(eventData);
        print("=============OnBeginDrag");
    }

    public override void OnEndDrag(PointerEventData eventData)
    {
        base.OnEndDrag(eventData);
        print("=============OnEndDrag");
        controller.setMovingFlag(false);
    }
    public override void OnInitializePotentialDrag(PointerEventData eventData)
    {
        base.OnInitializePotentialDrag(eventData);
        print("=============OnInitializePotentialDrag");
    }


}