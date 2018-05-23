;#DropDB HowToInitializeObjectCreatedViaNewActionEasyTest

#Application HowToInitializeObjectCreatedViaNewActionWin
#Application HowToInitializeObjectCreatedViaNewActionWeb

*Action Navigation(User)

*ProcessRecord
 Full Name = ''

#IfDef HowToInitializeObjectCreatedViaNewActionWeb
*Action Edit
#EndIf
 
*FillForm
 Full Name = Test User
 
*Action Cancel

#IfDef HowToInitializeObjectCreatedViaNewActionWin
*HandleDialog
 Respond = Yes
#EndIf

*CheckFieldValues
 Full Name = ''
