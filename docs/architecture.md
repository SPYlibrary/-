# 架构说明

## 目标

提供一个足够小、可验证、可扩展的 .NET 项目骨架，让 Visual Studio、GitHub 和 ChatGPT/Codex 在同一套约束下协作。

## 分层

- `AiDevWorkstation.Core`：不依赖 UI 或基础设施的核心逻辑。
- `AiDevWorkstation.Core.Tests`：核心行为的快速单元测试。

新增应用层、基础设施层或用户界面时，应保持依赖方向指向核心层，避免核心逻辑依赖具体框架或外部服务。

## 质量门槛

- Release 构建零警告；警告视为错误。
- 所有行为变化必须有自动化测试。
- NuGet 依赖使用锁文件，并由 Dependabot 更新。
- Pull Request 必须通过 GitHub Actions。

## 决策记录

重要架构变更应在 `docs/decisions/` 新增简短 ADR，说明背景、选择、替代方案和后果。
