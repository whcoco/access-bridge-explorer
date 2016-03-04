// Copyright 2016 Google Inc. All Rights Reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System.Windows.Forms;

namespace AccessBridgeExplorer {
  public interface IExplorerFormView {
    string Caption { get; }

    IMessageQueue MessageQueue { get; }

    ToolStripButton RefreshButton { get; }
    ToolStripButton FindComponentButton { get; }

    TabPage AccessibilityTreePage { get; }
    TreeView AccessibilityTree { get; }

    PropertyListView AccessibleComponentPropertyList { get; }

    TabPage MessageListPage { get; }
    ListView MessageList { get; }
    TabPage EventListPage { get; }
    ListView EventList { get; }

    ToolStripMenuItem PropertiesMenu { get; }
    ToolStripMenuItem EventsMenu { get; }

    ToolStripStatusLabel StatusLabel { get; }

    void ShowMessageBox(string message, string title, MessageBoxButtons buttons, MessageBoxIcon icon);
    void ShowDialog(Form form);
    void FocusMessageList();
    void ShowNotification(NotificationPanelEntry entry);
  }
}