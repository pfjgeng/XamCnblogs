﻿using Android.Content;
using Android.Runtime;
using Android.Widget;
using XamCnblogs.Droid.Renderers;
using XamCnblogs.UI.Controls;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CommentEditor), typeof(CommentEditorRenderer))]

namespace XamCnblogs.Droid.Renderers
{
    public class CommentEditorRenderer : EditorRenderer
    {
        public CommentEditorRenderer(Context context) : base(context)
        {

        }
        protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                var element = e.NewElement as CommentEditor;
                this.Control.Hint = element.Placeholder;
                this.Control.TextSize = 13;
                this.Control.Background = Context.GetDrawable(Resource.Drawable.commenteditor);

                IntPtr IntPtrtextViewClass = JNIEnv.FindClass(typeof(TextView));
                IntPtr mCursorDrawableResProperty = JNIEnv.GetFieldID(IntPtrtextViewClass, "mCursorDrawableRes", "I");
                JNIEnv.SetField(Control.Handle, mCursorDrawableResProperty, Resource.Drawable.color_cursor);
            }
        }
    }
}