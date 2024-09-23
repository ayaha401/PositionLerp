using UnityEngine;
using UnityEditor;

namespace AyahaGraphicComponents
{
    /// <summary>
    /// オブジェクトの位置をスライダーの割合で移動させる
    /// </summary>
    [ExecuteAlways]
    [DisallowMultipleComponent]
    public class PositionLerp : MonoBehaviour
    {
        /// <summary>
        /// 移動割合
        /// </summary>
        [SerializeField, Range(0f, 1f)]
        private float _lerpRate = 0.0f;

        /// <summary>
        /// 開始位置
        /// </summary>
        [SerializeField, ContextMenuItem("開始位置を設定", "SetStartPos")]
        private Vector3 _startPos;

        /// <summary>
        /// 終了位置
        /// </summary>
        [SerializeField, ContextMenuItem("終了位置を設定", "SetEndPos")]
        private Vector3 _endPos;

        /// <summary>
        /// 以前の割合
        /// </summary>
        private float _beforeRate = 0f;

        private void Start()
        {
            _beforeRate = _lerpRate;
        }

        private void Update()
        {
            SetPos();
        }

        /// <summary>
        /// 割合に応じた位置に移動させる
        /// </summary>
        private void SetPos()
        {
            if(_beforeRate != _lerpRate)
            {
                float posX = Mathf.Lerp(_startPos.x, _endPos.x, _lerpRate);
                float posY = Mathf.Lerp(_startPos.y, _endPos.y, _lerpRate);
                float posZ = Mathf.Lerp(_startPos.z, _endPos.z, _lerpRate);
                gameObject.transform.localPosition = new Vector3(posX, posY, posZ);

                _beforeRate = _lerpRate;
            }            
        }

        /// <summary>
        /// 開始位置をSetする
        /// </summary>
        private void SetStartPos()
        {
            Undo.RecordObject(this, "SetStartPos");
            _startPos = transform.localPosition;
        }

        /// <summary>
        /// 終了位置を設定する
        /// </summary>
        private void SetEndPos()
        {
            Undo.RecordObject(this, "SetEndPos");
            _endPos = transform.localPosition;
        }
    }
}
