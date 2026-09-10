# 🎮 Game Portfolio

โปรเจกต์เกมต้นแบบที่พัฒนาด้วย **Unity และ C#** ซึ่งเป็นโปรเจกต์เกมแรกที่ผมพัฒนาขึ้นด้วยตนเอง

โปรเจกต์นี้จัดทำขึ้นเพื่อเรียนรู้พื้นฐานด้าน **Game Development** และการเขียนโปรแกรมด้วย Unity ตั้งแต่เริ่มต้น พร้อมทั้งนำความรู้ด้าน Programming และ Software Development จากการเรียน Computer Science มาประยุกต์ใช้ในการสร้างเกมที่สามารถทดลองเล่นได้จริง

โปรเจกต์นี้เป็นส่วนหนึ่งของ Portfolio เพื่อแสดงถึงความสนใจและความตั้งใจในการพัฒนาตนเองในสาย **Game Development / Gameplay Programming**

---

## 📌 รายละเอียดโปรเจกต์

โปรเจกต์นี้เป็นเกมแรกที่ผมพัฒนาขึ้นด้วย Unity โดยเริ่มจากการเรียนรู้พื้นฐานของ Game Development และค่อย ๆ นำความรู้ที่ได้มาทดลองสร้างระบบต่าง ๆ ภายในเกมด้วยตนเอง

ระบบที่ศึกษาและพัฒนาในโปรเจกต์นี้ประกอบด้วย Player Movement, Camera Control, Input System, Animation และ Interaction System

เป้าหมายหลักของโปรเจกต์คือการทำความเข้าใจว่า **ระบบต่าง ๆ ภายในเกมทำงานและเชื่อมต่อกันอย่างไร** รวมถึงพัฒนาทักษะด้าน Programming, Debugging และ Problem Solving ผ่านการลงมือทำจริง

---

## 🛠️ Tech Stack

- **Game Engine:** Unity
- **Programming Language:** C#
- **Input:** Unity Input System
- **Camera:** Cinemachine
- **Version Control:** Git / GitHub

---

## 🎯 Technical Highlights

### Player Controller

- พัฒนาระบบการเคลื่อนที่ของตัวละครด้วย `CharacterController`
- ระบบ Gravity และ Jump
- ระบบตรวจสอบสถานะการอยู่บนพื้น
- เชื่อมต่อการเคลื่อนไหวกับ Animation

### Input System

- ใช้งาน Unity Input System
- รองรับการควบคุมตัวละครด้วย Keyboard
- แยกส่วนการรับ Input ออกจาก Logic ของระบบเกม

### Third-Person Camera

- พัฒนาระบบกล้องมุมมอง Third-Person
- ควบคุมการหมุนกล้องและทิศทางของตัวละคร
- ใช้งาน Cinemachine
- ปรับการเคลื่อนที่และมุมมองของกล้องให้เหมาะกับการควบคุมตัวละคร

### Interaction System

- ตรวจจับวัตถุด้วย Raycast
- ใช้ LayerMask เพื่อกำหนดวัตถุที่สามารถ Interaction ได้
- ตรวจสอบทิศทางและระยะห่างระหว่างผู้เล่นกับวัตถุ
- ศึกษาโครงสร้างของระบบ Interaction ภายในเกม

### Animation

- ใช้งาน Animator Controller
- สร้าง Animation State สำหรับการเคลื่อนไหว
- เชื่อมต่อ Player Movement กับ Animation

---

## 📚 สิ่งที่ได้เรียนรู้

โปรเจกต์นี้เป็นจุดเริ่มต้นของการเข้าสู่สาย **Game Development จากพื้นฐานด้าน Computer Science**

ก่อนเริ่มโปรเจกต์นี้ ผมมีประสบการณ์ด้าน Game Development ค่อนข้างจำกัด จึงเลือกเรียนรู้ผ่านการลงมือสร้างโปรเจกต์จริง และค่อย ๆ นำแนวคิดด้าน Programming มาประยุกต์ใช้กับระบบต่าง ๆ ภายในเกม

สิ่งที่ได้ศึกษาและฝึกฝน ได้แก่

- Unity Game Development Workflow
- C# Programming
- Object-Oriented Programming (OOP)
- Unity Input System
- Character Controller
- Camera System
- Raycast และ Collision Detection
- Animation System
- Interaction System
- Debugging และ Problem Solving
- Git และ Version Control

สิ่งสำคัญที่ได้จากโปรเจกต์นี้ไม่ใช่เพียงการทำให้เกมสามารถทำงานได้ แต่คือการทำความเข้าใจว่า **แต่ละระบบทำงานอย่างไร และระบบเหล่านั้นเชื่อมต่อกันอย่างไร**

---

## 🚧 สถานะโปรเจกต์

**In Development**

โปรเจกต์นี้ยังอยู่ระหว่างการพัฒนาและเรียนรู้ โดยจะมีการเพิ่มเติมระบบและปรับปรุงโครงสร้างอย่างต่อเนื่อง

ปัจจุบันเน้นการพัฒนาพื้นฐานของระบบ Player, Camera, Animation และ Interaction เพื่อใช้เป็นพื้นฐานสำหรับการพัฒนาระบบเกมที่ซับซ้อนมากขึ้นในอนาคต

---

## 🔮 สิ่งที่วางแผนพัฒนาต่อ

- [ ] เพิ่มระบบ NPC
- [ ] เพิ่ม Basic AI Behavior
- [ ] เพิ่มระบบ Interaction ให้รองรับวัตถุหลากหลายประเภท
- [ ] ปรับปรุง Animation และ Character Controller
- [ ] เพิ่มระบบ Dialogue
- [ ] ปรับปรุงโครงสร้าง Code ให้สามารถขยายและเพิ่มระบบใหม่ได้ง่ายขึ้น
- [ ] ศึกษาและทดลองนำ LLM มาประยุกต์ใช้กับระบบโต้ตอบและบทสนทนาของ NPC

---

## ▶️ วิธีการใช้งาน

### Requirements

- Unity
- Git

### ขั้นตอนการติดตั้ง

1. Clone Repository

```bash
git clone https://github.com/enjoywithnawaphat/Game_porfolio.git
```

2. เปิดโปรเจกต์ผ่าน Unity Hub

3. เปิด Main Scene ของโปรเจกต์

4. กด **Play** เพื่อทดลองเล่น

> Unity Version ที่ใช้ในการพัฒนาอาจมีการเปลี่ยนแปลงระหว่างการพัฒนา สามารถตรวจสอบ Version ที่ใช้ในปัจจุบันได้จาก Project Settings หรือไฟล์ภายใน Repository

---

## 💡 สิ่งที่ผมได้จากการทำโปรเจกต์นี้

สิ่งสำคัญที่ผมได้เรียนรู้จากโปรเจกต์นี้คือ การพัฒนาเกมไม่ได้มีเพียงการเขียน Code แต่ประกอบไปด้วยระบบหลายส่วนที่ต้องทำงานร่วมกัน

การทำโปรเจกต์นี้ทำให้ผมได้ฝึกกระบวนการ

> **Learn → Build → Debug → Understand → Improve**

แทนที่จะเพียงทำตาม Tutorial ผมพยายามทำความเข้าใจว่า Code และระบบแต่ละส่วนทำงานอย่างไร รวมถึงนำความรู้มาทดลองแก้ไขและพัฒนาต่อยอดด้วยตนเอง

---

## 👨‍💻 เกี่ยวกับผม

ผมเป็นนักศึกษาสาขา **วิทยาการคอมพิวเตอร์และนวัตกรรมการพัฒนาซอฟต์แวร์** มหาวิทยาลัยศรีปทุม และมีความสนใจด้าน **Game Development, Software Development และ AI**

แม้ว่า Game Development จะเป็นสายที่ผมเพิ่งเริ่มศึกษา แต่ผมกำลังเรียนรู้ Unity และ C# อย่างต่อเนื่องผ่านการพัฒนาโปรเจกต์จริง พร้อมนำพื้นฐานด้าน Computer Science และ Programming มาประยุกต์ใช้ในการทำความเข้าใจระบบต่าง ๆ ของเกม

ปัจจุบันผมสนใจโอกาสในการพัฒนาทักษะในตำแหน่ง

- **Game Programmer**
- **Unity Developer**
- **Full Stack Developer**
- **Backend Developer**
---

## 🔗 Links

**GitHub:**  
https://github.com/enjoywithnawaphat

**Game Portfolio Repository:**  
https://github.com/enjoywithnawaphat/Game_porfolio

---

⭐ โปรเจกต์นี้ยังคงพัฒนาอย่างต่อเนื่อง เพื่อเรียนรู้และพัฒนาทักษะด้าน Game Development และ Programming ให้ดียิ่งขึ้น