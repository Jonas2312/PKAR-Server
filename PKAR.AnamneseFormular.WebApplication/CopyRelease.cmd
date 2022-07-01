echo j | del ..\..\..\Release\PKAR.AnamneseFormular
mkdir ..\..\..\Release\PKAR.AnamneseFormular
xcopy "%1*.dll" ..\..\..\Release\PKAR.AnamneseFormular\ /Y
xcopy "%1*.exe" ..\..\..\Release\PKAR.AnamneseFormular\ /Y
xcopy "%1*.json" ..\..\..\Release\PKAR.AnamneseFormular\ /Y
del ..\..\..\Release\PKAR.AnamneseFormular.zip
set PATH=%PATH%;C:\Program Files\7-Zip\
7z a ..\..\..\Release\PKAR.AnamneseFormular.zip ..\..\..\Release\PKAR.AnamneseFormular\