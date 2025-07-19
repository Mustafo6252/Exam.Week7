## 1-BO‘LIM: Controller va Asinxronlik

Quyidagi vazifalarda siz Web API controller endpointlarini yaratishingiz kerak. Har bir topshiriq uchun mos marshrut (`GET`) endpoint bo‘ladi. Asinxronlik va metodlar bilan ishlashga e’tibor qarating.


### 1. Tasodifiy son qaytarish  
**🔗 Endpoint:** `GET /api/tools/random`  
**📝 Sharti:** 0 dan 100 gacha bo‘lgan tasodifiy butun sonni qaytaring.

📎 **Rasm:** 
<img width="600" height="900" alt="Screenshot 2025-07-19 at 19 44 08" src="https://github.com/user-attachments/assets/280b407c-66ae-48a9-8410-7a0cc502925e" />

---

### 2. Asinxron salomlashish  
**🔗 Endpoint:** `GET /api/tools/greet?name=Ali`  
**📝 Sharti:** 2 soniya kutib, `Salom, Ali` deb javob qaytaring. Metod asinxron bo‘lishi kerak.

📎 **Rasm:** <img width="600" height="900" alt="Screenshot 2025-07-19 at 19 44 50" src="https://github.com/user-attachments/assets/6608f0b2-401e-4e08-b3eb-299b48b9f583" />

---

### 3. Bugungi sanani qaytarish  
**🔗 Endpoint:** `GET /api/tools/today`  
**📝 Sharti:** Bugungi sanani `yyyy-MM-dd` formatida matn ko‘rinishida qaytaring.

📎 **Rasm:** <img width="600" height="900" alt="Screenshot 2025-07-19 at 19 45 19" src="https://github.com/user-attachments/assets/238e41d8-779d-4a76-ad3d-baa8af782a03" />

---

### 4. Matn uzunligini qaytarish  
**🔗 Endpoint:** `GET /api/tools/length?text=Salom`  
**📝 Sharti:** Berilgan `text` parametrining uzunligini butun son ko‘rinishida qaytaring.

📎 **Rasm:** <img width="600" height="900" alt="Screenshot 2025-07-19 at 19 45 50" src="https://github.com/user-attachments/assets/76a32540-ee43-4f06-9ee4-8eb5fab47f58" />

---

### 5. Kvadrat ildizini hisoblash  
**🔗 Endpoint:** `GET /api/tools/sqrt?value=81`  
**📝 Sharti:** Berilgan `value` sonining kvadrat ildizini (√81 = 9) qaytaring.  
**Qo‘llanishi mumkin:** `Math.Sqrt()` funksiyasi.

📎 **Rasm:** <img width="600" height="900" alt="Screenshot 2025-07-19 at 19 46 20" src="https://github.com/user-attachments/assets/4636ed96-c29b-4478-9567-cb1b536b1501" />

---

## 2-BO‘LIM: Fayl va Kataloglar bilan ishlash

Quyidagi vazifalarda siz fayllar va kataloglar bilan ishlashni amalda bajarishingiz kerak. Bunda .NET tizimidagi `System.IO` imkoniyatlaridan foydalaniladi.

---

### 1. `'C:\Temp'` papkasi mavjudligini tekshiring  
**Sharti:**  
Kompyuterda `C:\Temp` papkasi mavjud yoki yo‘qligini aniqlang.

---

### 2. `'test.txt'` nomli faylni yarating  
**Sharti:**  
Joriy papkada `test.txt` nomli yangi fayl yarating.

---

### 3. Fayl haqida ma’lumot oling  
**Sharti:**  
Yaratilgan `test.txt` faylining nomi, hajmi va yaratilgan vaqti haqida ma’lumot oling.

---

### 4. Ikki path (yo‘l) ni birlashtiring  
**Sharti:**  
Ikkita alohida fayl yo‘lini birlashtirib, bitta to‘liq yo‘l hosil qiling (masalan, papka va fayl nomini birlashtirish).

---

### 5. Faylga yozing va o‘qing  
**Sharti:**  
`test.txt` fayliga matn yozing va yozilgan matnni fayldan o‘qib ekranga chiqaring.

---
