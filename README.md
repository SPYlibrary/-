# AI 软件开发工作站模板

这是一个面向 Windows、Visual Studio、GitHub 与 ChatGPT/Codex 协作的最小可运行模板。它使用 .NET 10、xUnit、依赖锁文件和 GitHub Actions，适合作为新项目的安全起点。

## 快速开始

1. 使用 Visual Studio 打开 `AiDevWorkstation.slnx`。
2. 在“测试资源管理器”中运行全部测试。
3. 从 `main` 创建 `feature/<issue>-<name>` 或 `fix/<issue>-<name>` 分支。
4. 提交前执行：

```powershell
dotnet restore --locked-mode
dotnet build --configuration Release --no-restore
dotnet test --configuration Release --no-build
```

## 目录

- `src/`：产品代码。
- `tests/`：自动化测试。
- `docs/`：架构与维护说明。
- `.github/`：CI、Dependabot、Issue 和 Pull Request 模板。
- `AGENTS.md`：ChatGPT/Codex 等 AI 工具必须遵循的协作规则。

## 工作流

- `main` 必须保持可构建、可测试。
- 每项工作使用独立短分支和 Pull Request。
- 推荐提交格式：`feat: ...`、`fix: ...`、`test: ...`、`docs: ...`、`chore: ...`。
- 推荐使用 squash merge，并在合并后删除功能分支。
- 不得提交密码、Token、API key、连接字符串或本机私有配置。

## AI 协作

让 AI 修改代码前，先让它阅读 `README.md`、`AGENTS.md` 和 `docs/architecture.md`。每次任务应说明目标、允许修改的范围、验收标准和禁止操作。

## 维护

- 每周检查 Dependabot Pull Request。
- 每月更新 Visual Studio、Git、GitHub CLI 和 GitHub Desktop。
- 每季度复核 CI、分支规则和 `AGENTS.md`。
- 升级 .NET SDK 时同步修改 `global.json`，并在本地与 CI 中完整验证。
