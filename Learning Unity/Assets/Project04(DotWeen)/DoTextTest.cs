using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

namespace DOTweenProject
{
    public class DoTextTest : MonoBehaviour
    {
        private Text _text;
        private string _testText = "TestTextTestTextTestTextTestTextTestTextTestTextTestTextTestTextTestTextTestTextTestTextTestTextTestTextTestText";

        private void Awake() =>
            _text = GetComponent<Text>();

        void Start() =>
            _text.DOText(_testText, 3, true, ScrambleMode.All);
    }
}
