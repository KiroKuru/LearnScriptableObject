# LearnScriptableObject
 -Event
 
  利用ScriptableObject定義Event，且可以通過CreateAsset創建出各種不同的Event，
  Event裡提供Raise()，調用時將事件發送出去。
  
  另外需要一個Event接收的類，要設定處理哪種Event以及接收後調用的方法，
  當OnEnble時自動註冊相關的Event。

 -RuntimeSet
 
  利用ScriptableObject定義RuntimeSet，建立繼承RuntimeSet的專用Set，
  並透過CreateAsset創建其Instance。
  
  物件透過OnEnble/OnDisable加入或移出Set，其他腳本可透過RuntimeSet控制物件。
