# 📁 C#에서 CommonOpenFileDialog를 사용한 폴더 선택

`CommonOpenFileDialog`는 Microsoft.WindowsAPICodePack.Dialogs 네임스페이스에 포함된 **고급 폴더 선택 대화상자**입니다.  
기존의 `FolderBrowserDialog`보다 UI가 현대적이며 사용성도 뛰어납니다.

![img1 daumcdn](https://github.com/user-attachments/assets/8d82bccc-eff9-48eb-af66-761d2b781e63)


<br><br>

## 📦 NuGet 패키지 설치

먼저 NuGet 패키지로 Windows API Code Pack을 설치합니다.

![img1 daumcdn](https://github.com/user-attachments/assets/5be849f2-9f70-4689-a723-0e01c079b454)


```bash
PM > NuGet\Install-Package Microsoft-WindowsAPICodePack-Shell -Version 1.1.5
```


<br><br>

## 🧪 기본 사용 예제 (WinForms 기준)

```csharp

using Microsoft.WindowsAPICodePack.Dialogs;
using System.Windows.Forms;

private void btnSelectFolder_Click(object sender, EventArgs e)
{
    using (var dialog = new CommonOpenFileDialog())
    {
        dialog.IsFolderPicker = true;
        dialog.Title = "작업 폴더를 선택하세요";
        dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
        {
            string selectedFolder = dialog.FileName;
            MessageBox.Show("선택한 폴더: " + selectedFolder);
        }
    }
}

```

<br><br>


## ⚙️ 주요 속성 설명

| 속성명             | 설명 |
|--------------------|------|
| `IsFolderPicker`   | 폴더 선택 전용으로 설정 (`true` 필수) |
| `InitialDirectory` | 처음 열리는 폴더 경로 |
| `Title`            | 대화상자 제목 |
| `FileName`         | 선택된 폴더 경로 (읽기 전용) |

<br><br>

## ⚠️ 주의사항 ⚠️

- `CommonOpenFileDialog`는 **WinForms 또는 WPF 환경에서만 작동**합니다.
- 프로젝트의 **Target Framework는 .NET Framework 4.5 이상**이 필요합니다.
- Windows API Code Pack은 **관리자 권한 없이도 작동**하지만,
  가상경로나 특수 폴더 접근 시 일부 제한이 있을 수 있습니다.

<br><br>
