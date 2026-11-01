# AI 协作规范

## 开始任务前

1. 阅读 `README.md` 和 `docs/architecture.md`。
2. 检查工作树状态，保留用户已有修改。
3. 明确目标、范围、验收标准和风险；不确定时先询问。

## 修改边界

- 只修改当前任务需要的文件，不重写无关代码。
- 不读取、复制或上传工作区外的私有代码。
- 不提交密钥、Token、Cookie、密码、个人数据或本机配置。
- 新增依赖、联网、发布、创建云资源或更改权限前必须说明原因并取得确认。
- 不绕过测试、分支保护、安全检查或人工审查。
- 不使用破坏性 Git 命令覆盖用户工作。

## 必须验证

```powershell
dotnet restore --locked-mode
dotnet build --configuration Release --no-restore
dotnet test --configuration Release --no-build
```

若无法执行某项验证，必须明确说明原因和未覆盖的风险。

## 提交与交付

- 保持提交小而聚焦，使用清晰的命令式提交信息。
- Pull Request 说明应包含：问题、方案、验证、风险与回滚方法。
- 只有在 CI 通过、讨论已解决且变更可回滚时才合并。
