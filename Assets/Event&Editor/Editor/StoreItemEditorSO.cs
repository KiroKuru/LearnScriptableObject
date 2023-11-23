using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(StoreItemSO))]
public class StoreItemEditorSO : Editor
{
    private AudioSource _previewAudioSource;
    private StoreItemSO _target;
    private void OnEnable() {
        _target=target as StoreItemSO;

       _previewAudioSource=EditorUtility.CreateGameObjectWithHideFlags(name:"AudioPreview",
       HideFlags.HideAndDontSave,
       typeof(AudioSource)).GetComponent<AudioSource>();
    }

    // Objects created as hide and don't save must be explicitly destroyed by the owner of the object.
    private void OnDisable() {
        DestroyImmediate(_previewAudioSource);
    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if(GUILayout.Button("PreviewAudio")){
            _target.Play(_previewAudioSource);
        }
    }
}
