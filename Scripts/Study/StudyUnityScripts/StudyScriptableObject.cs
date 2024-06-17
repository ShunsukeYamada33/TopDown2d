using System;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable/Study", fileName = "���O")]
[Serializable]
public class StudyScriptableObject : ScriptableObject
{
    // ScriptableObject �X�N���v�^�u���I�u�W�F�N�g
    // MonoBehavior �ł͂Ȃ� Unity �ő�؂ȃN���X

    // �Q�[���I�u�W�F�N�g�Ƃ����`�ł͂Ȃ� Unity ���ŗ��p�ł���B
    
    // �G�̃p�����[�^
    public string enemyName;
    public int health;
    public int attack;

    // �V�[���Ԃ̃f�[�^���L
    // �R���t�B�O��ʂŐݒ肵��
    // �퓬��ʂł���𗘗p����

    // �퓬��ʂł̓Q�[���I�u�W�F�N�g�̃X�e�[�^�X�Ƃ���
    // �}�Ӊ�ʂł̓X�e�[�^�X��\���p


    // [CreateAssetMenu(menuName = "Scriptable/Study", fileName = "���O")]
    // menuName  Unity Editor �ŃN���G�C�g����ۂ̖��O�̐錾
    // fileName  �N���G�C�g�����ۂ̏����̖��O

    // Serializable  Unity Editor �ŗ��p�ł���悤�ɂ��邽�߂̂��܂��Ȃ�
}
