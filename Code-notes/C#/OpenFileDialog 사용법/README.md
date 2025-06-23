# 📂 C#에서 OpenFileDialog를 사용한 파일 불러오기

`OpenFileDialog`는 사용자가 파일을 탐색하고 선택할 수 있도록 해주는 **표준 Windows 대화상자**입니다.  
WinForms 또는 WPF 환경 모두에서 사용할 수 있으며, 선택한 파일 경로를 코드에서 쉽게 사용할 수 있습니다.

<br><br>

## 🧪 기본 사용 예제 (WinForms 기준)

```csharp
using System;
using System.Windows.Forms;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void btnLoadFile_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();

        openFileDialog.Title = "파일 선택";
        openFileDialog.Filter = "텍스트 파일 (*.txt)|*.txt|모든 파일 (*.*)|*.*";
        openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            string selectedPath = openFileDialog.FileName;
            MessageBox.Show("선택한 파일 경로: " + selectedPath);
        }
    }
}
```

<br><br>


## ⚙️ 주요 속성 설명

| 속성명             | 설명 |
|--------------------|------|
| `Title`            | 대화상자 상단 제목 텍스트 |
| `Filter`           | 허용되는 파일 형식 설정 (`"이름|확장자"`) |
| `InitialDirectory` | 처음 열리는 기본 폴더 경로 |
| `FileName`         | 사용자가 선택한 파일 전체 경로 |
| `Multiselect`      | 다중 선택 허용 여부 (기본: `false`) |

<br><br>

## ⚠️ 주의사항 ⚠️

- 대화상자 호출 전에 `STAThread`가 설정된 상태여야 정상 작동합니다.  
  👉 WinForms는 기본적으로 `STAThread`이지만, **Console App이나 WPF에서는 명시적으로 설정**이 필요할 수 있습니다.

- `Filter` 문자열은 반드시 `"설명|확장자"` 형태여야 합니다.  
  ✅ 형식 오류가 있을 경우 대화상자가 정상적으로 열리지 않습니다.

<br>

```csharp
openFileDialog.Filter = "텍스트 파일 (*.txt)|*.txt|모든 파일 (*.*)|*.*";
```

<br><br>
