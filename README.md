ความเป็นมา : ด้วยความส่วนตัวแล้วผมเป็นคนชอบดูอนิเมะแล้วอนิเมะก็ช่วยเติมเต็มชีวิตของผมได้ผมเลยอยากจะแนะนำสิ่งดีๆให้คนอื่นได้รู้จักอนิเมะมากขึ้น

วัตถุประสงค์ของโปรแกรม : ผมอยากจะแนะนำอนิเมะเพื่อให้คนอื่นได้ผ่านชั่วเวลาที่เลวร้ายสำหรับใครบางคนได้

โครงสร้างของโปรแกรม (Class diagram) ของโปรแกรม ใช้ Mermaid ในการเขียน : 

```mermaid
classDiagram
    Form1 -- CsvWriter
    Form1 -- Action
    Form1 -- Drama
    Action --> Cartoon
    Drama --> Cartoon

class Form1 {
        -ButtonREAD1_Click()
        -ButtonREAD2_Click()
        -ButtonREAD3_Click()
        -ButtonREAD4_Click()
        -ButtonREAD5_Click()
        -ButtonREAD6_Click()
        -buttonblack_Click()
        -buttonblackdrama_Click()
        -CSV_Click()
        -ReadCSV_Click()
    }

    class CsvWriter {
        +WriteToCsv(int[] count): bool
        +ReadFile(): bool
    }

    class Action {
        +pic1: Image
        +pic2: Image
        +pic3: Image
    }

    class Drama {
        +pic4: Image
        +pic5: Image
        +pic6: Image
    }

        class Cartoon{
        -Lineart: string
        -type: string
        -name: string
        -efm: int
        +Get_high(): int
    }
```

ชื่อของผู้พัฒนาโปรแกรม : นายจิรกิตติ์ โลหะวาทิน 
รหัส นศ. : 663450173-3 
