using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMove : MonoBehaviour
{
    PlayerInput _input;

    private Vector2 moveDirection;
    private Vector2 cameraMove;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _input = GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void OnMove(InputValue value)
    {
        moveDirection = value.Get<Vector2>();
        // Debug.Log($"Input Vector: {moveDirection}");
    }

    public void OnLook(InputValue value)
    {
        cameraMove = value.Get<Vector2>();
    }

    private void Move()
    {


        Vector3 move = new Vector3(moveDirection.x, 0, moveDirection.y);

        if (moveDirection != Vector2.zero)
        {
            Vector3 camRot = Camera.main.transform.rotation.eulerAngles;//カメラの回転角度
            Quaternion quaCam = Quaternion.Euler(0, camRot.y, 0);//カメラのYだけをQuaternionに変換
            float angle = Mathf.Atan2(moveDirection.x, moveDirection.y) * Mathf.Rad2Deg;//進行方向の角度計算
            Quaternion newQua = Quaternion.Euler(0, angle, 0) * quaCam;//進行角度Quaternion
            transform.localRotation = newQua;//回転させる
            move = Vector3.Scale(transform.forward, new Vector3(1, 0, 1));//xz平面の移動ベクトル
        }

        transform.position += move * Time.deltaTime * 5f;
    }

    private void CameraRotation()
    {
               Vector3 camRot = Camera.main.transform.rotation.eulerAngles;//カメラの回転角度
        Quaternion quaCam = Quaternion.Euler(0, camRot.y, 0);//カメラのYだけをQuaternionに変換
        float angle = Mathf.Atan2(cameraMove.x, cameraMove.y) * Mathf.Rad2Deg;//進行方向の角度計算
        Quaternion newQua = Quaternion.Euler(0, angle, 0) * quaCam;//進行角度Quaternion
        transform.localRotation = newQua;//回転させる
    }
}
