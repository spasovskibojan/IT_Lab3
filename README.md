# IT_Lab3
Интернет технологии
Да се направи MVC апликација за закажување на прегледи во една болница. Во моделите имаме
класи за Patient, Doctor и Hospital. Еден пациент може да оди на преглед кај повеќе доктори. Даден
доктор работи само во една болница. (Креирајте ја базата врз основа на дадените релации)
Да се направат контролери за трите модели од дадената база со Create, Edit, Details и Delete
функционалности.
a. Сликата (Image) на болницата во листата на болници и во погледот за детали на
болницата како слика, а не како string (url линк).
b. Во погледот за Edit на пациентот, за полот на пациентот (Gender) да се направи
DropDown листа (или RadioButton) за избор на машки/женски пол.
c. Името на пациентот во листата на пациенти да биде линк до Details акцијата за тој
пациент.
d. Во листата со доктори, да се прикаже дополнително името и адресата на болницата
во која докторот е вработен.
2. Во менито да се ажурираат линковите да водат кон соодветните контролери кои ќе бидат
креирани. Имињата на линковите да бидат Пациенти, Лекари и Болници, соодветно.
3. Во веќе постоечкиот модел за пациентот(Patient) да се направи името на пациентот да биде
задолжително, а кодот на пациентот да биде цел број составен од точно 5 цифри.
Променливата PatientCode во погледите да се прикажува како “Код на пациентот”. По
измените во моделот треба да ја ажурирате базата со додавање на нова миграција преку
add-migration ImeNaMigracija, па потоа update-database командите во Package Manager
Console.
4. Да се имплементира додавање на пациент(Patient) за даден доктор. Во Details погледот за
докторот, да се направи копче Додади пациент по што ќе се отвори форма во која ќе се
испише името на докторот за сакаме да додадеме пациент, а самиот пациент ќе се избере
од паѓачко мени (DropDown) пополнето со сите пациенти во базата. Во истиот поглед Details,
Да се листаат во ul листа сите пациенти кои биле на преглед кај докторот, со линк кон
нивната Details страна (од Patients контролерот). По успешно додавање на пациент кај
докторот, да се направи Redirect до Details страната на истиот доктор.
5. Да се имплементира приказ на листата на доктори. За секој ред да се имплементира Delete
функцијата за доктор
